const ENV = {
  dev: {
    apiUrl: 'http://localhost:44307',
    oAuthConfig: {
      issuer: 'http://localhost:44307',
      clientId: 'AbpBoilerPlate_App',
      clientSecret: '1q2w3e*',
      scope: 'AbpBoilerPlate',
    },
    localization: {
      defaultResourceName: 'AbpBoilerPlate',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44307',
    oAuthConfig: {
      issuer: 'http://localhost:44307',
      clientId: 'AbpBoilerPlate_App',
      clientSecret: '1q2w3e*',
      scope: 'AbpBoilerPlate',
    },
    localization: {
      defaultResourceName: 'AbpBoilerPlate',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
