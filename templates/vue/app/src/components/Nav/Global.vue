<template>
  <header class="text-gray-600 body-font">
  <div class="container mx-auto flex flex-wrap p-5 flex-col md:flex-row items-center">
    <a class="flex title-font font-medium text-gray-900 mb-4 md:mb-0" href="/">
      <img src="/img/minics.png" alt="ASP.NET Minimal API" style="max-height:30px"/>
    </a>
    <nav class="md:ml-auto flex flex-wrap items-center text-base justify-center">
      <a class="mr-5 hover:text-gray-900" v-for="(link,idx) of topNav" :key="idx" :href="link.url">{{ link.name }}</a>
    </nav>
    <button class="inline-flex items-center bg-gray-100 border-0 py-1 px-3 focus:outline-none hover:bg-gray-200 rounded text-base mt-4 md:mt-0">Button
      <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-1" viewBox="0 0 24 24">
        <path d="M5 12h14M12 5l7 7-7 7"></path>
      </svg>
    </button>
  </div>
</header>
</template>
<script setup>
import {useSiteStore} from "@/stores/site.js";
const {topNav} = useSiteStore();
</script>