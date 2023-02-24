<template>
  <TwelveEighty class="mt-12">
    <Hero :doc="dummy" />
  </TwelveEighty>
</template>

<script setup>
import TwelveEighty from "@/components/Blocks/1280.vue";
import Hero from "@/components/Blocks/Hero.vue";
import { useDummyStore } from '@/stores/dummy';

//helper library for working with comoponents
const {dummy, getDummy} = useDummyStore();
getDummy();

</script>
