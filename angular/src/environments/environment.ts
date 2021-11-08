import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Mall',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44358',
    redirectUri: baseUrl,
    clientId: 'Mall_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone Mall',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44306',
      rootNamespace: 'TangBunao.Mall',
    },
  },
} as Environment;
