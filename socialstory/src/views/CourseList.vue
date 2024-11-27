<template>
  <div>
    <h1>課程列表</h1>
    <ul>
      <li v-for="course in courses" :key="course.id">
        <router-link :to="`/course/${course.id}`">{{ course.title }}</router-link>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  data() {
    return {
      courses: [
        { id: 'story1', title: '課程 1' },
        { id: 'story2', title: '課程 2' },
        // 添加更多課程
      ]
    };
  }
};
</script>

<style scoped>
/* 添加樣式 */
</style>