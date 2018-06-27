import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export class Dummy {
    Risk: string;
    Category: string;
    AreaOfRisk: string;
    Relevance: number;
    Owner: string;
    Year: number;

    constructor(dummy: object) {
        this.Risk = dummy['risk'];
        this.Category = dummy['category'];
        this.AreaOfRisk = dummy['areaOfRisk'];
        this.Relevance = dummy['relevance'];
        this.Owner = dummy['owner'];
        this.Year = dummy['year'];
    }
}

@Injectable({
    providedIn: 'root'
})
export class DummyService {

    url = 'http://localhost:21021/api';
    constructor(private http: HttpClient) { }

    getDummyData() {
        return this
            .http
            .get(`${this.url}/Dummy/GetData`);
    }
}
