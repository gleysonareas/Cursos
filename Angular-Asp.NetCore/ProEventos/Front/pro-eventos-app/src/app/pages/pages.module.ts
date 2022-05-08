import { Component, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Eventos } from './eventos/eventos';
import { Palestrantes } from './palestrantes/palestrantes';
import { ComponentsModule } from 'src/shared/components/components.module';

@NgModule({
  declarations: [
    Eventos, 
    Palestrantes
  ],
  imports: [
    CommonModule,
    ComponentsModule
  ],
  exports: [
    ComponentsModule,
    Eventos, 
    Palestrantes,
  ]
})
export class PagesModule { }
