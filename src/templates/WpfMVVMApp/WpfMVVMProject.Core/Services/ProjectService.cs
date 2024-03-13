using System.Threading.Tasks;
using WpfMVVMProject.Core.Models;

namespace WpfMVVMProject.Core.Services
{
	public class ProjectService : IProjectService
	{
		public async Task<ProjectInfo> CreateProjectAsync()
		{
			var projInfo = new ProjectInfo() { Id = "1" };
			return await Task.FromResult(projInfo);
		}
	}
}
