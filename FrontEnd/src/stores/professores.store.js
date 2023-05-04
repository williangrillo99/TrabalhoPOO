import { defineStore } from 'pinia';

const baseUrl = `${import.meta.env.VITE_API_URL}/Professsor`;

export const useProfessorStore = defineStore({
    id: 'professores',

    state: () => ({
        professores: {},
    }),
    actions : {
        async getAll(){
            this.professores = {location: true};
            try{
                this.professores = await fetchWrapper.get(`${baseUrl}/ListarUsuario`); 
            }
            catch (error){
                return false;
            }
            
        }
    }
})