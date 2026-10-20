import { defineConfig } from 'astro/config';

// https://astro.build/config
export default defineConfig({
  publicDir: './wwwroot',
  server: {
    port: 4321,
    host: true
  }
});
