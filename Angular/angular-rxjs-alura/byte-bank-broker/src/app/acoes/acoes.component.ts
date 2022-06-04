import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Acoes } from './models/acoes';
import { AcoesService } from './services/acoes.service';
import { Subscription, merge } from 'rxjs';
import { tap, switchMap, filter, debounceTime, distinctUntilChanged } from 'rxjs/operators';

const ESPERA_DIGITACAO = 300;

@Component({
  selector: 'app-acoes',
  templateUrl: './acoes.component.html',
  styleUrls: ['./acoes.component.css'],
})

export class AcoesComponent implements OnInit, OnDestroy{

  public acoesInput = new FormControl();

  public todasAcoes$ = this.acoesService.getAcoes().pipe(
    tap(() => {
      console.log('Fluxo Inicial');
    })
  );

  public filtroPeloInput$ = this.acoesInput.valueChanges.pipe(
    debounceTime(ESPERA_DIGITACAO),
    tap(() => {
      console.log('Fluxo do Filtro');
    }),
    tap(console.log),
    filter(
      (valorDigitado) => valorDigitado.length >= 3 || !valorDigitado.length
    ),
    distinctUntilChanged(),
    switchMap((valorDigitado) => this.acoesService.getAcoes(valorDigitado)),
    tap(console.log)
  );

  //A função merge serve para combinar mais de um observable.
  public acoes$ = merge(this.todasAcoes$, this.filtroPeloInput$);
  // private subscription: Subscription;

  constructor(private acoesService: AcoesService) { }
  
  public ngOnInit(): void {
  //  this.acoesService.getAcoes().subscribe((retornoApi) => {
  //    this.acoes = retornoApi.payload;
  //  })

  //  this.acoesService.getAcoes().subscribe((acoes) => {
  //    this.acoes = acoes;
  //  })

  //  this.subscription = this.acoesService.getAcoes().subscribe((acoes) => {
  //    this.acoes = acoes;
  //  })
  }

  public ngOnDestroy(): void {
  //Com o unsubscribe garantimos que as subscription serão encerradas de maneira correta sem ocasionar memory leak.
  //   this.subscription.unsubscribe();
  }
}
