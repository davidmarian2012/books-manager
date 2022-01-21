import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Action } from 'rxjs/internal/scheduler/Action';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})
export class BookComponent implements OnInit {


  public subscription: Subscription | undefined;
  public id: any;

  constructor(
    private route: ActivatedRoute,
  ) { }

  ngOnInit(): void {
  }


}
