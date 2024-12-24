using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFinder.Domain
{
    public class ApplicationDataContext
    {
        public List<Employed> Employeds { get; set; }

        public ApplicationDataContext()
        {
            this.Employeds = new() {
                new Employed(){
                    Id=100,
                    Name="Fernando Sepulveda",
                    Speciality="Electricista",
                    Category=Categories.Technology,
                    Address="Calle 10b#30",
                    Description="Como electricista, ofrezco una amplia gama de servicios para satisfacer las necesidades eléctricas de clientes residenciales y comerciales. Mis principales habilidades y servicios incluyen:\r\n\r\nInstalación y reparación de sistemas eléctricos, asegurando un funcionamiento seguro y eficiente.\r\nMantenimiento y actualización de cableado eléctrico para cumplir con las normativas actuales.\r\nInstalación de iluminación interior y exterior, mejorando la funcionalidad y estética de los espacios.\r\nDiagnóstico y solución de problemas eléctricos, proporcionando reparaciones rápidas y efectivas.",
                    Email="fernando@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=22,
                    Gender="Masculino",
                    Stars=4.9,
                    Phone="+57 3002224455",
                    Skills = new(){ "Solución de Problemas", "Instalaciones Eléctricas", "Mantenimiento" }
                },
                new Employed(){
                    Id=101,
                    Name="Laura Martínez",
                    Speciality="Esteticista",
                    Category=Categories.Beauty,
                    Address="Calle 11b#30",
                    Description="Como esteticista, ofrezco una amplia gama de tratamientos de belleza para ayudar a mis clientes a verse y sentirse mejor. Mis principales habilidades y servicios incluyen:\r\n\r\nTratamientos faciales y corporales para una piel radiante.\r\nDepilación profesional con cera y láser.\r\nMaquillaje para eventos especiales y asesoramiento en cosméticos.\r\nMasajes relajantes y terapéuticos para el bienestar general.",
                    Email="laura@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/415829/pexels-photo-415829.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=28,
                    Gender="Femenino",
                    Stars=4.8,
                    Phone="+57 3003335566",
                    Skills = new(){ "Tratamientos Faciales", "Depilación", "Maquillaje" }
                },
                new Employed(){
                    Id=102,
                    Name="Carlos Pérez",
                    Speciality="Albañil",
                    Category=Categories.Construction,
                    Address="Calle 100 # 11-20",
                    Description="Como albañil, tengo experiencia en la construcción y reparación de estructuras de diversos tipos. Mis principales habilidades y servicios incluyen:\r\n\r\nConstrucción de muros, pavimentos y techos.\r\nReparación y remodelación de espacios interiores y exteriores.\r\nInstalación de revestimientos y azulejos.\r\nTrabajos de cimentación y estructuras básicas.",
                    Email="carlos@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/709188/pexels-photo-709188.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=35,
                    Gender="Masculino",
                    Stars=4.7,
                    Phone="+57 3004446677",
                    Skills = new(){ "Construcción de Muros", "Reparación", "Instalación de Revestimientos" }
                },
                new Employed(){
                    Id=103,
                    Name="Ana Gómez",
                    Speciality="Enfermera",
                    Category=Categories.Health,
                    Address="Carrera 10#30-45",
                    Description="Como enfermera, brindo atención médica profesional y compasiva a mis pacientes. Mis principales habilidades y servicios incluyen:\r\n\r\nAdministración de medicamentos y tratamientos.\r\nCuidado de pacientes postoperatorios y crónicos.\r\nMonitoreo de signos vitales y asistencia en procedimientos médicos.\r\nEducación y apoyo a pacientes y sus familias sobre el manejo de la salud.",
                    Email="ana@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/1065084/pexels-photo-1065084.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=30,
                    Gender="Femenino",
                    Stars=4.9,
                    Phone="+57 3005557788",
                    Skills = new(){ "Administración de Medicamentos", "Cuidado de Pacientes", "Monitoreo de Signos Vitales" }
                },
                new Employed(){
                    Id=104,
                    Name="Javier Ramírez",
                    Speciality="Paseador de Perros",
                    Category=Categories.Pets,
                    Address="Calle 12b",
                    Description="Como paseador de perros, ofrezco servicios confiables y atentos para el bienestar de tus mascotas. Mis principales habilidades y servicios incluyen:\r\n\r\nPaseos diarios y ejercicio para perros de todas las razas y tamaños.\r\nCuidado y atención personalizada durante los paseos.\r\nEntrenamiento básico y socialización de mascotas.\r\nReportes y actualizaciones regulares sobre el comportamiento de tu mascota.",
                    Email="javier@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/1222271/pexels-photo-1222271.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=25,
                    Gender="Masculino",
                    Stars=4.8,
                    Phone="+57 3006668899",
                    Skills = new(){ "Paseos Diarios", "Entrenamiento Básico", "Cuidado Personalizado" }
                },
                new Employed(){
                    Id=105,
                    Name="María Fernanda Torres",
                    Speciality="Profesora de Matemáticas",
                    Category=Categories.Education,
                    Description="Como profesora de matemáticas, me dedico a enseñar y motivar a mis estudiantes a comprender y amar las matemáticas. Mis principales habilidades y servicios incluyen:\r\n\r\nClases personalizadas y en grupos pequeños para todos los niveles.\r\nPreparación para exámenes y apoyo en tareas escolares.\r\nDesarrollo de materiales didácticos y recursos educativos.\r\nUso de métodos interactivos y tecnológicos para mejorar el aprendizaje.",
                    Email="maria@gmail.com",
                    Address="Calle 10#30b-21",
                    ImageProfile="https://images.pexels.com/photos/733872/pexels-photo-733872.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=32,
                    Gender="Femenino",
                    Stars=4.9,
                    Phone="+57 3007779900",
                    Skills = new(){ "Clases Personalizadas", "Preparación para Exámenes", "Desarrollo de Materiales Didácticos" }
                },
                new Employed(){
                    Id=106,
                    Name="Roberto Sánchez",
                    Speciality="Psicólogo",
                    Category=Categories.Psychology,
                    Address="Calle 10b#30",
                    Description="Como psicólogo, ofrezco apoyo y orientación profesional para ayudar a mis pacientes a superar sus desafíos emocionales y psicológicos. Mis principales habilidades y servicios incluyen:\r\n\r\nTerapia individual y grupal para todas las edades.\r\nEvaluaciones psicológicas y diagnósticos precisos.\r\nDesarrollo de planes de tratamiento personalizados.\r\nApoyo en la gestión del estrés, ansiedad y depresión.",
                    Email="roberto@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/614810/pexels-photo-614810.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=40,
                    Gender="Masculino",
                    Stars=4.9,
                    Phone="+57 3008881111",
                    Skills = new(){ "Terapia Individual", "Evaluaciones Psicológicas", "Gestión del Estrés" }
                },
                new Employed(){
                    Id=108,
                    Name="Santiago López",
                    Speciality="Desarrollador de Software",
                    Category=Categories.Technology,
                    Address="Calle 10b#30",
                    Description="Como desarrollador de software, creo aplicaciones y soluciones tecnológicas innovadoras. Mis principales habilidades y servicios incluyen:\r\n\r\nDesarrollo de aplicaciones web y móviles.\r\nDiseño y mantenimiento de bases de datos.\r\nImplementación de soluciones de software personalizadas.\r\nPruebas y optimización de aplicaciones para mejorar el rendimiento.",
                    Email="santiago@gmail.com",
                    ImageProfile="https://images.pexels.com/photos/91227/pexels-photo-91227.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Age=29,
                    Gender="Masculino",
                    Stars=4.8,
                    Phone="+57 3001113344",
                    Skills = new(){ "Desarrollo Web", "Diseño de Bases de Datos", "Optimización de Aplicaciones" }
                }
            };
        }
    }
}
