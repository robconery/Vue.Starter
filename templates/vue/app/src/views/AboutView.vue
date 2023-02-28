<template>
  <TwelveEighty class="mt-12">
    <Hero :doc="doc" />
  </TwelveEighty>
</template>

<script setup>
import TwelveEighty from "@/components/Blocks/1280.vue";
import Hero from "@/components/Blocks/Hero.vue";

const doc = {
  title: "Lorem Ipsum",
  html: "Velit tempor ea laboris velit anim ad exercitation do qui veniam. In anim laborum qui duis ullamco sit reprehenderit adipisicing ullamco reprehenderit dolore dolore. Duis veniam ullamco commodo reprehenderit laboris sit. Et incididunt ea magna excepteur ullamco dolore culpa in. Deserunt minim voluptate culpa Lorem nulla in velit.",
  image: `https://dummyimage.com/540x460`,
  link: "#"
};
</script>
