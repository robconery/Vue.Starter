<template>
  <div class="container mx-auto flex px-5 md:flex-row flex-col items-center">
    <div class="lg:max-w-lg lg:w-full md:w-1/2 w-5/6 mb-10 md:mb-0">
      <img class="object-cover object-center rounded" alt="hero" :src="doc.image">
    </div>
    <div class="lg:flex-grow md:w-1/2 lg:pl-24 md:pl-16 flex flex-col md:items-start md:text-left items-center text-center">
      <h1 class="title-font sm:text-4xl text-3xl mb-4 font-medium text-gray-900">{{ doc.title }}</h1>
      <div class="mb-8 leading-relaxed" v-html="doc.html"></div>
      <div class="flex justify-center">
        <slot></slot>
      </div>
    </div>
  </div>
</template>
<script setup>
defineProps({
  doc: {
    type: Object,
    required: true,
    default: {
      title: "Lorem Ipsum",
      html: "Fugiat qui ad pariatur consectetur elit irure adipisicing in. Tempor do dolore minim ea excepteur nostrud. Occaecat ut adipisicing minim proident eiusmod ut excepteur ad ullamco nulla. Ullamco exercitation Lorem elit dolore veniam mollit exercitation nisi anim ea anim enim voluptate in. Ullamco ut laboris quis excepteur.",
      image: "https://dummyimage.com/720x600"
    }
  }
});
</script>