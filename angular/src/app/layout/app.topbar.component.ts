import { Component, ElementRef, ViewChild, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { AuthService } from '../shared/services/auth.service';
import { LayoutService } from "./service/app.layout.service";
import { Router } from '@angular/router';
import { LOGIN_URL } from '../shared/constants/urls.const';

@Component({
    selector: 'app-topbar',
    templateUrl: './app.topbar.component.html'
})
export class AppTopBarComponent implements OnInit {
  items!: MenuItem[];
  userMenuItems: MenuItem[];

  @ViewChild('menubutton') menuButton!: ElementRef;
  @ViewChild('topbarmenubutton') topbarMenuButton!: ElementRef;
  @ViewChild('topbarmenu') menu!: ElementRef;

  constructor(
    public layoutService: LayoutService,
    private authService: AuthService,
    private router: Router
  ) { }

  ngOnInit() {
    this.userMenuItems = [
      {
        label: 'Xem thông tin cá nhân',
        icon: 'pi pi-id-card',
        routerLink: ['/profile'],
      },
      {
        label: 'Đổi mật khẩu',
        icon: 'pi pi-key',
        routerLink: ['/change-password'],
      },
      {
        label: 'Đăng xuất',
        icon: 'pi pi-sign-out',
        command: event => {
          this.authService.logout();
          this.router.navigate([LOGIN_URL]);
        },
      },
    ];
  }
}
