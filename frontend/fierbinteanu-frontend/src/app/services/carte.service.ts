import { HttpClient, HttpContext, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BooksComponent } from '../modules/books/books/books.component';

@Injectable({
  providedIn: 'root'
})
export class CarteService {

  public url = 'https://localhost:5001/api/carte';

  constructor(
    public http: HttpClient,
  ) { }

  public GetAllBooks(): Observable<any> {
    return this.http.get(`${this.url}`);
  }


  public addBook(book: any): Observable<any> {
    return this.http.post(`${this.url}`, book);
  }

  public deleteBook(id: any): Observable<any> {
    const options = {
      headers: new HttpHeaders(),
      body: id
    };
    const urlaux = this.url.concat('/').concat(id);
    return this.http.delete(`${urlaux}`, id);
  }
}
