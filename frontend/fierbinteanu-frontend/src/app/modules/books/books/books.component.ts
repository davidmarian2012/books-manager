import { Component, OnDestroy, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { CarteService } from 'src/app/services/carte.service';
import { DataService } from 'src/app/services/data.service';
import { AddEditBookComponent } from '../../shared/add-edit-book/add-edit-book.component';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.scss']
})
export class BooksComponent implements OnInit, OnDestroy {

  public subscription: Subscription | undefined;
  public loggedUser: any;
  public parentMessage = 'message from parent';
  public books = [];
  public displayedColumns = ['name', 'autorNume', 'profile', 'delete'];

  constructor(
    private router: Router,
    private dataService: DataService,
    private carteService: CarteService,
    public dialog: MatDialog,
  ) { }

  ngOnInit(): void {
    this.subscription = this.dataService.currentUser.subscribe(user => this.loggedUser = user);
    this.carteService.GetAllBooks().subscribe(
      (result) => {
        console.log(result);
        this.books = result;
      },
      (error) => {
        console.error(error);
      }
    )
  }

  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }

  public logout(): void {
    localStorage.setItem('Role', 'User');
    this.router.navigate(['/login']);
  }
  public receiveMessage(event: any): void {
    console.log(event);
  }

  public deleteBook(id: any): void {
    this.carteService.deleteBook(id).subscribe(
      (result: any) => {
        console.log(result);
        this.carteService.GetAllBooks().subscribe(
          (result) => {
            console.log(result);
            this.books = result;
          },
          (error) => {
            console.error(error);
          }
        )
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  public openModal(): void {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = '550px';
    dialogConfig.height = '700px';
    const dialogRef = this.dialog.open(AddEditBookComponent, dialogConfig);
    dialogRef.afterClosed().subscribe(
      (result) => {
        console.log(result);
        if (result) {
          this.carteService.GetAllBooks().subscribe(
            (result) => {
              console.log(result);
              this.books = result;
            },
            (error) => {
              console.error(error);
            }
          )
        }
      }
    )
  }

  public addNewBook(): void {
    this.openModal();
  }

  public goToBookProfile(id: any): void {
    this.router.navigate(['/book', id]);
  }
}
