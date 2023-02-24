<script setup>
import { RouterLink, RouterView } from 'vue-router'
import NavGlobal from "./components/Nav/Global.vue";
</script>

<template>
  <NavGlobal></NavGlobal>

    <Suspense>
      <RouterView />
    </Suspense>

</template>

<style scoped>
</style>
