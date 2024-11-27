<template>
  <div v-if="courseData">
    <h1>{{ courseData[0].text }}</h1>
    <div v-for="(item, index) in courseData" :key="index" class="story-item">
      <img :src="item.image" :alt="item.text" @click="playAudio(item.audio)" />
      <p>{{ item.text }}</p>
    </div>
  </div>
  <div v-else>
    Loading...
  </div>
</template>

<script>
export default {
  data() {
    return {
      courseData: null
    };
  },
  created() {
    const { id } = this.$route.params;
    fetch(`/${id}.json`)
      .then(response => response.json())
      .then(data => {
        this.courseData = data;
      });
  },
  methods: {
    playAudio(audioSrc) {
      const audio = new Audio(audioSrc);
      audio.play();
    }
  }
};
</script>

<style scoped>
.story-item {
  margin-bottom: 20px;
  text-align: center;
}

.story-item img {
  max-width: 100%;
  cursor: pointer;
}

.story-item p {
  margin: 10px 0 0;
}
</style>