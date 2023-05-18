import { defineStore } from 'pinia'

export const useContentStore = defineStore('content', {
  state(){
    return {
      documents: {},
      document: null,
    }
  },
  getters:{
    dummyDocument(){
    return {
        title: "Lorem Ipsum",
        html: "Velit tempor ea laboris velit anim ad exercitation do qui veniam. In anim laborum qui duis ullamco sit reprehenderit adipisicing ullamco reprehenderit dolore dolore. Duis veniam ullamco commodo reprehenderit laboris sit. Et incididunt ea magna excepteur ullamco dolore culpa in. Deserunt minim voluptate culpa Lorem nulla in velit.",
        image: `https://dummyimage.com/540x460`,
        link: "#"
      }
    }
  },
  actions:{
    async getDocuments(path){
      const endpoint = location.hostname.indexOf("localhost") >=0 ? "http://localhost:8000/api/content" : "/api/content"
      try{
        this.documents.length = 0;
        const url = `${endpoint}/${path}`;
        //TODO: Change this for production
        const res = await fetch(url);
        const docs = await res.json();
        //keep things reactive
        docs.forEach(d => {
          this.documents[d.slug.toLowerCase()] = d;
        });
      }catch(err){
        console.error(err);
      }

    }
  }
});
