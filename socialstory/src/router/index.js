import { createRouter, createWebHistory } from 'vue-router';
import CourseList from '../views/CourseList.vue';
import CourseDetail from '../views/CourseDetail.vue';

const routes = [
  { path: '/', component: CourseList },
  { path: '/course/:id', component: CourseDetail }
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;