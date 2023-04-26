import { defineStore } from 'pinia'

export const useSiteStore = defineStore('site', {
  state(){
    return {
      topNav: [
        {name: "Home", url: "/"},
        {name: "About", url: "/about/"},
      ],
      social: [
        {name: "Mastodon", url: "https://hachyderm.io/@robconery", icon: "fa fa-mastodon"},
        {name: "Blog", url: "https://asp.net", icon: ""},
        {name: "Docs", url: "https://hachyderm.io/@robconery", icon: "fa fa-book"},
        {name: "GitHub", url: "https://hachyderm.io/@robconery", icon: "fa fa-github"},
      ],
      footerNav: {
        categories: [
          {
            name: "Categories", links: [
              {name: "First", url: "#"},
              {name: "Second", url: "#"},
              {name: "Third", url: "#"},
              {name: "Fourth", url: "#"},
            ],
          },{
            name: "Categories", links: [
              {name: "First", url: "#"},
              {name: "Second", url: "#"},
              {name: "Third", url: "#"},
              {name: "Fourth", url: "#"},
            ],
          },{
            name: "Categories", links: [
              {name: "First", url: "#"},
              {name: "Second", url: "#"},
              {name: "Third", url: "#"},
              {name: "Fourth", url: "#"},
            ],
          }
        ]
      }
    }
  },
  getters : {
    contentEndpoint(){
     return location.hostname.indexOf("localhost") >=0 ? "http://localhost:8000/api/content" : "/api/content"
    }
  }
});