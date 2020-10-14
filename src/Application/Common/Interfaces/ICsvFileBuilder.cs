using cleandemo.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace cleandemo.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
