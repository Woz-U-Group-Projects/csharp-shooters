import { Component } from '@angular/core';
@Component ({
    selector: 'fetch-request',
    template: `<h1> Welcome </h1>
    <button type="button" (click) "this.getAPI()">Login!</button>
    <ul *ngFor = "let data of apiData">
    <li>{{data}}</li>
    <ul>
    `
})
export class GetRequestComponent {
    apiData;

    getApi() {
        const url ='http://localhost:5000/api';
        fetch(url)
        .then(resp => resp.json())
        .then(resp => (this.apiData = resp));
    }
}