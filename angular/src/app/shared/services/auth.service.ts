import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ACCESS_TOKEN, REFRESH_TOKEN } from "../constants/keys.const";
import { LoginRequestDto } from "../models/login-request.dto";
import { LoginResponseDto } from "../models/login-response.dto";
import { environment } from './../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private httpClient: HttpClient) {}

  public login(input: LoginRequestDto): Observable<LoginResponseDto> {
    let body = {
      username: input.username,
      password: input.password,
      client_id: environment.oAuthConfig.clientId,
      client_secret: environment.oAuthConfig.dummyClientSecret,
      grant_type: 'password',
      scope: environment.oAuthConfig.scope
    };

    // convert req has format like: "username=admin%40tcecommerce.com&password=123qwe&client_id=TCEcommerce_Admin&client_secret=1q2w3e*&grant_type=password&scope=TCEcommerce.Admin%20offline_access"
    const req = Object.keys(body).map((key) => `${key}=${encodeURIComponent(body[key])}`).join('&');
    return this.httpClient.post<LoginResponseDto>(environment.oAuthConfig.issuer + 'connect/token', req,
    { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } });
  }

  public isAuthenticated(): boolean {
    return localStorage.getItem(ACCESS_TOKEN) !== null;
  }

  public logout() {
    localStorage.removeItem(ACCESS_TOKEN);
    localStorage.removeItem(REFRESH_TOKEN);
  }
}
