import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44313/',
  redirectUri: baseUrl,
  clientId: 'ABPBoilerplateTeste_App',
  responseType: 'code',
  scope: 'offline_access ABPBoilerplateTeste',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ABPBoilerplateTeste',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44313',
      rootNamespace: 'ABPBoilerplateTeste',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
