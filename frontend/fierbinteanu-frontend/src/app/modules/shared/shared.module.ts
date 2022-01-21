import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddEditBookComponent } from './add-edit-book/add-edit-book.component';
import { MaterialModule } from '../material/material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HoverBtnDirective } from 'src/app/hover-btn.directive';



@NgModule({
  declarations: [
    AddEditBookComponent,
    HoverBtnDirective,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule,
  ],
  entryComponents: [
    AddEditBookComponent
  ],
  exports: [
    HoverBtnDirective,
  ]
})
export class SharedModule { }
