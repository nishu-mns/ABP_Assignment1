import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Assigment',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44324/',
    redirectUri: baseUrl,
    clientId: 'Assigment_App',
    responseType: 'code',
    scope: 'offline_access Assigment',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44324',
      rootNamespace: 'Assigment',
    },
  },
} as Environment;
