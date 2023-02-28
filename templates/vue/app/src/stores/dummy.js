import { defineStore } from 'pinia'

//This store helps you create blocked CMS components using Lorem Ipsum
export const useDummyStore = defineStore('dummy', {
  state(){
    return {
      docs: [],
      dummy: {}
    }
  },
  actions:{
    getDummies(count = 3, imageDimensions = "540x460"){

      for(let i = 1; i <= count; i++){
        const dummy = this.getDummy(imageDimensions);
        this.docs.push(dummy);
      }
    },
    getDummy(imageDimensions = "540x460"){
      this.dummy = {
        title: "Lorem Ipsum",
        html: "Velit tempor ea laboris velit anim ad exercitation do qui veniam. In anim laborum qui duis ullamco sit reprehenderit adipisicing ullamco reprehenderit dolore dolore. Duis veniam ullamco commodo reprehenderit laboris sit. Et incididunt ea magna excepteur ullamco dolore culpa in. Deserunt minim voluptate culpa Lorem nulla in velit.",
        image: `https://dummyimage.com/${imageDimensions}`,
        link: "#"
      }
    }
  }
});
