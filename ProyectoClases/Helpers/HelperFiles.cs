using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //NECESITAMOS DOS METODOS: LEER Y ESCRIBIR
        //LOS METODOS DEBEN SER ASINCRONOS
        //EN LOS METODOS DE CLASE DEBEMOS UTILIZAR 
        //LA CLASE TASK PARA METODOS ASINCRONOS
        //NO SE UTILIZA VOID
        //1) Si es un void, se utiliza Task
        //2) Si es un return, utilizamos Task<ClaseReturn>

        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using(TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);

            using(TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

        #region COMENTARIOS
        //    //TENEMOS UNA CLASE LLAMADA FileInfo QUE NOS DEVUELVE UN FILE
        //    //Y PODEMOS GENEREAR UN WRITER/READER
        //    FileInfo file = new FileInfo(this.Path);
        //        //CREAMOS EL FICHERO
        //        using (TextWriter writer = file.CreateText())
        //        {
        //            string content = this.GetNombresListBox();
        ////ESCRIBIMOS EN EL FICHERO
        //await writer.WriteAsync(content);
        ////DESPUES DE ESCRIBIR, DEBEMOS LIBERAR LA MEMORIA
        ////PARA HACERLO FIJO
        //await writer.FlushAsync();
        ////CERRAMOS EL FICHERO
        //writer.Close();
        //            MessageBox.Show("Fichero almacenado");
        #endregion

    }
}
