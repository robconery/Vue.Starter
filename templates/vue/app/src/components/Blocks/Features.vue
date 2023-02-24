<template>

  <div class="container px-5 mx-auto">
    <h1 class="sm:text-3xl text-2xl font-medium title-font text-center text-gray-900 mb-20" v-if="title"> {{ title }}
    </h1>
    <div class="flex flex-wrap sm:-m-4 -mx-4 -mb-10 -mt-4 md:space-y-0 space-y-6" >
      <div class="p-4 md:w-1/3 flex"  v-for="(item,idx) of items" :key="idx">
        <div class="w-12 h-12 inline-flex items-center justify-center rounded-full bg-indigo-100 text-indigo-500 mb-4 flex-shrink-0">
          <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-6 h-6" viewBox="0 0 24 24">
            <path d="M22 12h-4l-3 9L9 3l-3 9H2"></path>
          </svg>
        </div>
        <div class="flex-grow pl-6">
          <h2 class="text-gray-900 text-lg title-font font-medium mb-2">{{ item.title }}</h2>
          <p class="leading-relaxed text-base" v-html="item.html"></p>
          <a class="mt-3 text-indigo-500 inline-flex items-center" :href="item.link">Learn More
            <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-2" viewBox="0 0 24 24">
              <path d="M5 12h14M12 5l7 7-7 7"></path>
            </svg>
          </a>
        </div>
      </div>
    </div>
  </div>

</template>
<script setup>
defineProps({
  items: {
    type: Array,
    default: []
  },
  title: {
    type: Object
  }
});
</script>