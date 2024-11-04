
(04-11-2024)

- se agrega gestion de turnos x especialidad

- se mueve el menu de ratificar turnos al menu de Sala de espera
- se agrega el formulario de consulta de historia clinica, que permite buscar paciente por DNI o por Nombre
- desde este fomulario, se habilita el boton de ir al diagnostico (con el paciente seleccionado)
- se agrega el formulario de Registrar atencion del paciente, que permite agregar la informacion del medico a la historia clinica



(30-10-2024)

- se completa el formulario de ratificacion de turnos
- se agrega cuadro de dialogo con informacion del turno registrado en RegistroTurnoP
- se estandarizan todos lo messagebox de RegistroTurnoP
- ( SQL ) se agrega al campo estado de la tabla turnos las opciones : ratificado y vencido 
- ( SQL ) se cambia el campo paciente de la tabla turnos para que guarde el documento en vez del Id del paciente
- ( SQL ) se agrega el campo pago a la tabla turnos 



(29-10.2024)

- cambio en la tabla turnos el campo paciente a INT, para que quede igual que en tabla paciente
- se completa el registro de turno por profesional para que quede reservado en la base con el dni del paciente



(28-10-2024)

- Se restablecen el funcionamiento de registro de pacientes y medicos para quer guarden en base de datos



(26-10-2024)

- Funcionan los botones de volver
- Se agrega menu de solicitud de tunnos x especialidad
- Se agrega menu de solicitud de tunnos x medico
- Se cambian los messagebox para que salgan por consola con Debug.WriteLine


- No se que paso que dejaron de funcionar los registros de medicos y pacientes (queda a revisar mañana)





- 
Usuarios cargados:

'Admin' '1234'

'Cristian' '1234'

'Heber' '1234'

