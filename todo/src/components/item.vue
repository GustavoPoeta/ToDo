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
    <div 
        class="w-80 h-24 bg-indigo-300 
        text-indigo-900 font-mono
        rounded-2xl flex items-center justify-center 
        transition-all
        hover:cursor-pointer hover:scale-[110%]"
    >

        <h2 class="text-xl">{{ name }}</h2>

    </div>
</template>