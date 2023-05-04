import { Layout, ListaProfessor } from '@/views/professor';

export default {
    path: '/professor',
    component: Layout,
    children: [
        { path: '', component: ListaProfessor },
        
    ]
};
