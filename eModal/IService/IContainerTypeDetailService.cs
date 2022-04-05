using eModal.Request;

namespace eModal.IService
{
    public interface IContainerTypeDetailService
    {
        Task<IResult> GetContainerTypeDetails();

        Task<IResult> GetContainerTypeDetailById(int id);

        Task<IResult> CreateContainerTypeDetail(ContainerTypeDetailRequest ContainerTypeDetail);

        Task<IResult> UpdateContainerTypeDetail(int id, ContainerTypeDetailRequest ContainerTypeDetail);

        Task<IResult> DeleteContainerTypeDetail(int id);
    }
}
