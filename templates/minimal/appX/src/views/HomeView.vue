<script setup lang="ts">
import { useContentStore } from '../stores/content.js';

const {getDocuments, documents} = useContentStore();
await getDocuments("home");
console.log(documents)
</script>

<template>
  <main>
    <h2>HEKEKE</h2>
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
  </main>
</template>


