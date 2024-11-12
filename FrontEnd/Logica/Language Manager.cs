using System.Collections.Generic;

namespace FrontEnd
{
    public static class LanguageManager
    {
        // Diccionario para almacenar textos en diferentes idiomas
        private static readonly Dictionary<string, Dictionary<string, string>> _translations;

        static LanguageManager()
        {
            _translations = new Dictionary<string, Dictionary<string, string>>
        {
            { "english", new Dictionary<string, string>
                {
                    { "btn_EnviarMensaje", "Send" },
                    { "btn_escribir", "Message" },
                    { "txt_DescripcionVacio", "No biography" },
                    { "btn_VolverFeed", "Back to Feed" },
                    { "Seguir", "Follow" },
                    { "btn_CancelarEditar", "Cancel" },
                    { "DejarSeguir", "Unfollow:" },
                    { "BusquedaUsuariosForm", "Search Users" },
                    { "lbl_DescripcionUsuario", "Biography: " },
                    { "btn_confirmarEditar", "Save" },
                    { "btn_editarPerfil", "Edit Profile" },
                    { "lbl_Seguidos", "Following: " },
                    { "lbl_Seguidores", "Followers: " },
                    { "lbl_InstrumentoUsuario", "Instrument: " },
                    { "lbl_PublicacionesCreadas", "Posts:" },
                    { "mensaje_ContraseñaError", "The password must be between 8 and 30 characters, or the previous password is incorrect"},
                    { "titulo_ContraseñaError", "Error" },
                    { "mensaje_Confirmado", "The password has been changed successfully" },
                    { "titulo_Confirmado", "Successfull" },
                    { "btn_confirmarCambioC", "Confirm" },
                    { "lbl_contraseniaNueva", "New Password:" },
                    { "lbl__contraseniaAnterior", "Previus\nPassword:" },
                    { "btn_buscar", "Search" },
                    { "lbl_confirmarEliminar", "Sure?" },
                    { "btn_confirmarEliminar", "Yes" },
                    { "btn_eliminarCuenta", "Delete Account" },
                    { "lbl_foto_perfil", "Profile Photo" },
                    { "btn_foto_perfil", "Upload Photo" },
                    { "error_nombreexistente", "This username already exists" },
                    { "Publicar", "Post" },
                    { "lbl_cuentaPrivada", "Private Account:" },
                    { "btn_cambiar_contraseña", "Change password" },
                    { "btn_crear_banda", "Create a band" },
                    { "btn_ver_bloqueados", "View blocked accounts" },
                    { "placeholder", "Search..." },
                    { "Configuracion", "Configuration" },
                    { "Salir", "Exit" },
                    { "Mis_Bandas", "Bands" },
                    { "lbl_otro", "Other :" },
                    { "cambiar_modo_claro", "Switch to light mode" },
                    { "cambiar_modo_oscuro", "Switch to dark mode" },
                    { "btn_cerrarsesion", "Logout and exit" },
                    { "lbl_usuario", "Username :" },
                    { "lbl_contrasenia", "Password :" },
                    { "lbl_nombre", "Name :" },
                    { "lbl_confirmarcontrasenia", "Confirm\nPassword :" },
                    { "lbl_tipoCuenta", "Musician Account :" },
                    { "btn_continuar", "Confirm" },
                    { "btn_ingresar", "Login" },
                    { "btn_registrarse", "Register" },
                    { "txt_derechos", "© 2024 DexCorp. All rights reserved." },
                    { "lbl_idioma", "Language"},
                    { "btb_salir", "Exit" },
                    { "error_login", "The username or password is incorrect" },
                    { "btn_volver", "Back" },
                    { "error_usuariolargo", "The username or name must be less than 30 characters" },
                    { "error_contrasenialargo", "The password must be between 8 and 30 characters long" },
                    { "error_vacio", "Options cannot be left blank" },
                    { "error_noiguales", "The passwords do not match" },
                    { "lbl_fechaNacimiento", "Date of\nBirth :" },
                    { "lbl_sexo", "Gender: " },
                    { "configuracionForm", "Configuration" },
                    { "error_instrumento", "If you are a musician, you must select an instrument." },

                }
            },
            { "español", new Dictionary<string, string>
                {
                    { "btn_EnviarMensaje", "Enviar" },
                    { "btn_escribir", "Mensaje" },
                    { "txt_DescripcionVacio", "Sin Biografia" },
                    { "btn_VolverFeed", "Volver al Feed" },
                    { "Seguir", "Seguir" },
                    { "btn_CancelarEditar", "Cancelar" },
                    { "DejarSeguir", "Dejar de Seguir" },
                    { "BusquedaUsuariosForm", "Busqueda de Usuarios" },
                    { "lbl_DescripcionUsuario", "Biografia: " },
                    { "btn_confirmarEditar", "Guardar" },
                    { "btn_seguir", "Seguir" },
                    { "btn_editarPerfil", "Editar Perfil" },
                    { "lbl_Seguidos", "Seguidos: " },
                    { "lbl_Seguidores", "Seguidores: " },
                    { "lbl_InstrumentoUsuario", "Instrumento: " },
                    { "lbl_PublicacionesCreadas", "Publicaciones:" },
                    { "mensaje_ContraseñaError", "La contraseña debe tener entre 8 y 30 caracteres o la contraseña anterior es incorrecta"},
                    { "titulo_ContraseñaError", "Error" },
                    { "mensaje_Confirmado", "La contraseña se ha cambiado correctamente" },
                    { "titulo_Confirmado", "Exito" },
                    { "btn_confirmarCambioC", "Confirmar" },
                    { "lbl_contraseniaNueva", "Contraseña Nueva:" },
                    { "lbl__contraseniaAnterior", "Contraseña\nAnterior:" },
                    { "btn_buscar", "Buscar" },
                    { "lbl_confirmarEliminar", "Seguro?" },
                    { "btn_confirmarEliminar", "Si" },
                    { "btn_eliminarCuenta", "Eliminar Cuenta" },
                    { "lbl_foto_perfil", "Foto de Perfil" },
                    { "btn_foto_perfil", "Subir Foto" },
                    { "error_nombreexistente", "Este nombre de usuario ya existe" },
                    { "Publicar", "Subir Publicacion" },
                    { "lbl_cuentaPrivada", "Cuenta Privada:" },
                    { "btn_cambiar_contraseña", "Cambiar Contraseña" },
                    { "btn_crear_banda", "Crear Banda" },
                    { "btn_ver_bloqueados", "Ver cuentas bloqueadas" },
                    { "placeholder", "Buscar..." },
                    { "Configuracion", "Configuracion" },
                    { "Salir", "Salir" },
                    { "Mis_Bandas", "Bandas" },
                    { "lbl_otro", "Otro :" },
                    { "cambiar_modo_claro", "Cambiar a modo Claro" },
                    { "cambiar_modo_oscuro", "Cambiar a modo Oscuro" },
                    { "btn_cerrarsesion", "Cerrar Sesion y Salir" },
                    { "lbl_usuario", "Usuario :" },
                    { "lbl_tipoCuenta", "Cuenta de Músico :" },
                    { "error_instrumento", "Si eres musico, debes seleccionar un instrumento" },
                    { "btn_continuar", "Confirmar" },
                    { "lbl_confirmarcontrasenia", "Confirmar\nContraseña :" },
                    { "lbl_nombre", "Nombre :" },
                    { "lbl_contrasenia", "Contraseña :" },
                    { "btn_ingresar", "Ingresar" },
                    { "btn_registrarse", "Registrarse" },
                    { "txt_derechos", "© 2024 DexCorp. Todos los derechos reservados." },
                    { "lbl_idioma", "     Idioma" },
                    { "btb_salir", "Salir"},
                    { "error_login", "El usuario o la contraseña son incorrectos" },
                    { "btn_volver", "Volver"},
                    { "error_usuariolargo", "El usuario o el nombre debe ser menor a 30 caracteres" },
                    { "error_contrasenialargo", "La contraseña debe tener un minimo de 8 y un maximo de 30 caracteres" },
                    { "error_vacio", "No se puede dejar opciones vacias" },
                    { "error_noiguales", "Las contraseñas no coinciden" },
                    { "lbl_fechaNacimiento", "Fecha de\nNacimiento :" },
                    { "lbl_sexo", "Genero: " },
                    { "configuracionForm", "Configuracion" },

        }
            }
        };
        }

        public static Dictionary<string, string> GetTranslations(string language)
        {
            Dictionary<string, string> translations;
            if (_translations.TryGetValue(language, out translations))
            {
                return translations;
            }

            return _translations["español"];
        }
    }


}
