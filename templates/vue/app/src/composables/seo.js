import { useHead } from 'unhead'
export function useSeo({title, description, image}){

  const bits =   [
    {hid: "title", name: "title", content: title},
    {hid: "description", name: "description", content: description},
    {hid: "og:title", name: "og:title", content: title},
    {hid: "og:description", name: "og:description", content: description},
    {hid: "og:image", name: "og:image", content:  `https://localhost:3000/images/${image}`},
    //set this when you know your site's root
    // {hid: "og:url", name: "og:url", content: `https://localhost:3000/${route.path}`},
    {hid: "twitter:title", name: "twitter:title", content: title},
    {hid: "twitter:description", name: "twitter:description", content: description},
    {hid: "twitter:image", name: "twitter:image", content: `https://localhost:3000/images/${image}`},
    {hid: "twitter:creator", name: "twitter:creator", content: "@robconery"},
    {hid: "twitter:site", name: "twitter:site", content: "@robconery"},
    {hid: "twitter:card", name: "twitter:card", content: "summary_large_image"}
  ]

  useHead({title: `${title} | Vue Starter`, description: description}, bits);
}