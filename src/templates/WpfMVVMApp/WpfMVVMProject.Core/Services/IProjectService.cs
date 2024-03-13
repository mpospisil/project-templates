using System.Threading.Tasks;
using WpfMVVMProject.Core.Models;

namespace WpfMVVMProject.Core.Services
{
	public interface IProjectService
	{
		public Task<ProjectInfo> CreateProjectAsync();
	}
}
