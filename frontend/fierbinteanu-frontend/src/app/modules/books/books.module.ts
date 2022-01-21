import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BooksRoutingModule } from './books-routing.module';
import { BooksComponent } from './books/books.component';
import { MaterialModule } from '../material/material.module';
import { ChildComponent } from './child/child.component';
import { BookComponent } from './book/book.component';


@NgModule({
  declarations: [
    BooksComponent,
    ChildComponent,
    BookComponent
  ],
  imports: [
    CommonModule,
    BooksRoutingModule,
    MaterialModule,
  ]
})
export class BooksModule { }
