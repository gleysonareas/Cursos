import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { map, tap, pluck } from 'rxjs/operators';
import { Acao, Acoes, AcoesAPI } from '../models/acoes';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AcoesService {
  constructor(private httpClient: HttpClient) {}

  //Aqui é criado um método que irá retornar um get com o meu objeto para o observador que no caso é o proprio método
  getAcoes(valor?: string): Observable<Acoes> {
    const params = valor ? new HttpParams().append('valor', valor) : undefined;
    return this.httpClient
      .get<AcoesAPI>('http://localhost:3000/acoes', { params })
      .pipe(
        //O operador tap não altera o fluxo ele apenas permiti que voce visualize o que está acontecendo no fluxo
        tap((valor) => console.log(valor)),
        //Com o pluck é possivel estrair a propriedade que está sendo recebida, sem necessidade de relizar um map para isso
        //apenas passando como string o nome da propriedade que eu quero extrair.
        pluck('payload'),
        map((acoes) =>
          acoes.sort((acaoA, acaoB) => this.ordenaPorCodigo(acaoA, acaoB))
        )
      );
  }

  private ordenaPorCodigo(acaoA: Acao, acaoB: Acao) {
    if (acaoA.codigo > acaoB.codigo) {
      return 1;
    }

    if (acaoA.codigo < acaoB.codigo) {
      return -1;
    }

    return 0;
  }
}
