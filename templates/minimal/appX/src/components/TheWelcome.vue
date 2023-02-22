<script setup>
import { useContentStore } from '@/stores/content';

const {getDocuments, documents} = useContentStore();
await getDocuments("home");
console.log(documents)
</script>

<template>
  <h1>WELL HOWDY</h1>
  <div class="item" v-for="doc in documents">
    <i>
      {{ doc.icon }}
    </i>
    <div class="details">
      <h3>
        {{ doc.title }}
      </h3>
      <slot></slot>
    </div>
  </div>
</template>
