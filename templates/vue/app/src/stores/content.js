import { defineStore } from 'pinia'

export const useContentStore = defineStore('content', {
  state(){
    return {
      documents: {},
      document: null,
      endpoint: location.hostname.indexOf("localhost") >= 0 ? "http://localhost:8000/api/content" : "/api/content"
    }
  },
  actions:{
    async getDocuments(path){

      try{
        this.documents.length = 0;
        //TODO: Change this for production
        const res = await fetch(`${this.endpoint}/${path}`);

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
})
