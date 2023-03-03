<template>
  <TwelveEighty class="mt-12">
    <Hero :doc="dummyDocument" />
  </TwelveEighty>
</template>

<script setup>
import TwelveEighty from "@/components/Blocks/1280.vue";
import Hero from "@/components/Blocks/Hero.vue";
import { useContentStore } from '@/stores/content'
import {useSeo} from "@/composables/seo";

const {dummyDocument} = useContentStore();

useSeo({
  title: "My About Page",
  description: "This is the About Page"
});

</script>
