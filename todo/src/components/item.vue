<script>
    export default {
        props: {
            name: {
                type: String,
                required: true,
            },
        },
    };
</script>

<template>
    <div class="w-80 h-24 bg-indigo-300 text-indigo-900 font-mono text-lg rounded-2xl flex items-center justify-center">
        <h2>{{ name }}</h2>
    </div>
</template>