<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Head from "./components/Nav/Global.vue";
import Footer from "./components/Nav/Footer.vue";
</script>

<template>
  <Head />
  <Suspense>
    <RouterView />
  </Suspense>
  <Footer class="mt-24" />
</template>

