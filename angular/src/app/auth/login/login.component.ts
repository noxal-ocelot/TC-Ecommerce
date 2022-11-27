import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { ACCESS_TOKEN, REFRESH_TOKEN } from 'src/app/shared/constants/keys.const';
import { LoginRequestDto } from 'src/app/shared/models/login-request.dto';
import { LoginResponseDto } from 'src/app/shared/models/login-response.dto';
import { AuthService } from 'src/app/shared/services/auth.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styles: [`
        :host ::ng-deep .pi-eye,
        :host ::ng-deep .pi-eye-slash {
            transform:scale(1.6);
            margin-right: 1rem;
            color: var(--primary-color) !important;
        }
    `]
})
export class LoginComponent implements OnInit, OnDestroy {
  valCheck: string[] = ['remember'];
  password!: string;

  loginForm: FormGroup;
  private ngUnsubscribe = new Subject<void>();

  constructor(
    public layoutService: LayoutService,
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router,
  ) {}

  ngOnInit(): void {
    this.initForm();
  }

  ngOnDestroy(): void {
    this.ngUnsubscribe.next();
    this.ngUnsubscribe.complete();
  }

  initForm() {
    this.loginForm = this.fb.group({
      username: new FormControl(null, Validators.required),
      password: new FormControl(null, Validators.required),
    });
  }

  login() {
    let request: LoginRequestDto = {
      username: this.loginForm.controls['username'].value,
      password: this.loginForm.controls['password'].value
    };
    this.authService.login(request)
      .pipe(takeUntil(this.ngUnsubscribe))
      .subscribe((resp: LoginResponseDto) => {
        console.log(resp)
        localStorage.setItem(ACCESS_TOKEN, resp.access_token);
        localStorage.setItem(REFRESH_TOKEN, resp.refresh_token);
        this.router.navigate(['']);
      });
  }
}
