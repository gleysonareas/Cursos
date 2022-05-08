import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PagesModule } from 'src/app/pages/pages.module';
import { NavComponent } from './nav/nav.component';

@NgModule({
  declarations: [NavComponent],
  imports: [
    CommonModule,
    PagesModule,
  ],
  exports: [
    PagesModule,
    NavComponent,
  ]
})
export class TemplateModule { }
