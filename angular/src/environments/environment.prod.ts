import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TCEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44362/',
    redirectUri: baseUrl,
    clientId: 'TCEcommerce_App',
    responseType: 'code',
    scope: 'offline_access TCEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44340',
      rootNamespace: 'TCEcommerce',
    },
  },
} as Environment;
