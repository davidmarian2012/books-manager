import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { CarteService } from 'src/app/services/carte.service';

@Component({
  selector: 'app-add-edit-book',
  templateUrl: './add-edit-book.component.html',
  styleUrls: ['./add-edit-book.component.scss']
})
export class AddEditBookComponent implements OnInit {

  public booksForm: FormGroup = new FormGroup({
    // id: new FormControl(0),
    name: new FormControl(0),
    autorNume: new FormControl(0),
  });
  constructor(
    private booksService: CarteService,
    public dialogRef: MatDialogRef<AddEditBookComponent>,
  ) { }

  //getters
  get id(): AbstractControl | null {
    return this.booksForm.get('id');
  }

  get name(): AbstractControl | null {
    return this.booksForm.get('name');
  }

  get autorNume(): AbstractControl | null {
    return this.booksForm.get('autorNume');
  }

  ngOnInit(): void {
  }

  public addBook(): void {
    this.booksService.addBook(this.booksForm.value).subscribe(
      (result) => {
        console.log(result);
        this.dialogRef.close(result);
      },
      (error) => {
        console.error(error);
      }
    )
  }

}
