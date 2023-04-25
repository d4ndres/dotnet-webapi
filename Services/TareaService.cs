using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_learn_entity_framework_core.Context;
using _02_learn_entity_framework_core.Models;

namespace webapi.Services
{
    public class TareaService : ITareaService
    {

        TareasContext dbContext;

        public TareaService(TareasContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Tarea> Get()
        {
            return dbContext.Tareas;
        }

        public async Task Save(Tarea tarea)
        {
            await dbContext.AddAsync(tarea);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(Guid id, Tarea tarea)
        {
            var tareaActual = dbContext.Tareas.Find(id);
            if( tareaActual != null )
            {
                tareaActual.CategoriaId = tarea.CategoriaId;
                tareaActual.Titulo = tarea.Titulo;
                tareaActual.Description = tarea.Description;
                tareaActual.PrioridadTarea = tarea.PrioridadTarea;
                tareaActual.FechaCreacion = tarea.FechaCreacion;

                // await dbContext.AddAsync(TareaActual);
                await dbContext.SaveChangesAsync();
            }
        }
        public async Task Delete(Guid id)
        {
            var TareaActual = dbContext.Tareas.Find(id);
            if( TareaActual != null )
            {
                dbContext.Remove(TareaActual);
                await dbContext.SaveChangesAsync();
            }
        }
    }
    public interface ITareaService
    {
        public IEnumerable<Tarea> Get();
        public Task Save(Tarea Tarea);
        public  Task Update(Guid id, Tarea Tarea);
        public  Task Delete(Guid id);
    }
}