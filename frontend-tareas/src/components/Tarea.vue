<template>
    <div>
        <h1 class="display-4 text-center">Listado de tareas</h1>
        <hr>
        <div class="row">
            <div class="col-lg-8 offset-lg-2">
                <div class="card mt-4">
                    <div class="card-body">
                        <div class="input-group">
                            <input type="text" v-model="tarea"
                            class="form-control form-control-lg" placeholder="Agregar tarea">
                            <div class="input-group-append">
                                <button v-on:click="agregarTarea()"
                                class="btn btn-success btn-lg">Agregar</button>
                            </div>
                        </div>
                        <br>
                        <h4 v-if="listTareas.length == 0">No hay tarea para realizar</h4>
                        <ul class="list-group">
                            <li v-for="(tarea,index) of listTareas" :key="index"
                            class="list-group-item d-flex justify-content-between">
                                <span class="cursor" v-on:click="editarTarea(tarea, index)">
                                    <i class="fa-regular fa-circle"></i>
                                </span>
                                {{ tarea.nombre }}
                                <span class="text-danger cursor" v-on:click="eliminarTarea(index)">
                                    <i class="fa-solid fa-trash"></i>
                                </span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name:"MyTarea",
        data(){
            return{
                tarea:'',
                listTareas:[]
            }
        },
        methods:{
            agregarTarea(){
               const tarea = {
                nombre: this.tarea,
                estado: false
               }
               this.listTareas.push(tarea);
               this.tarea='';
            },
            eliminarTarea(index){
                this.listTareas.splice(index,1);
            },
            editarTarea(tarea, index){
                this.listTareas[index].estado = !tarea.estado
            }
        }
    }
</script>

<style scoped>
.cursor{
    cursor: pointer;
}
</style>