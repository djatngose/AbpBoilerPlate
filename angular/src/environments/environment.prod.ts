export const environment = {
  production: true,
  application: {
    name: 'AbpBoilerPlate',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44385',
    clientId: 'AbpBoilerPlate_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'AbpBoilerPlate',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44345',
    },
  },
  localization: {
    defaultResourceName: 'AbpBoilerPlate',
  },
};
