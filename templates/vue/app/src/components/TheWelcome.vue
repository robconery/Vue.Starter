<script setup>
import WelcomeItem from './WelcomeItem.vue'
import { useContentStore } from '../stores/content'
const {getDocuments, documents} = useContentStore();
await getDocuments("home");
</script>

<template>
  <WelcomeItem v-for="thing of documents">
    <template #icon>
      <i class="fa-regular fa-star"></i>
    </template>
    <template #heading>{{ thing.title }}</template>
    <span v-html="thing.html"></span>
  </WelcomeItem>

</template>
