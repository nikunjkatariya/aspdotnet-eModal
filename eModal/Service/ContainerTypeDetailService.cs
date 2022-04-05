using Microsoft.EntityFrameworkCore;
using eModal.Models;
using eModal.Request;
using eModal.IService;
using eModal.Service;
using eModal;

public class ContainerTypeDetailService : IContainerTypeDetailService
{
    public readonly MainContext _context;

    public ContainerTypeDetailService(ContainerTypeDetailContext context)
    {
        _context = context;
    }

    public async Task<IResult> GetContainerTypeDetails()
    {
        return Results.Ok(await _context.ContainerTypeDetails.ToListAsync());
    }

    public async Task<IResult> GetContainerTypeDetailById(int id)
    {
        var containerTypeDetail = await _context.ContainerTypeDetails.FindAsync(id);

        return containerTypeDetail != null ? Results.Ok(containerTypeDetail) : Results.NotFound();
    }

    public async Task<IResult> CreateContainerTypeDetail(ContainerTypeDetailRequest containerTypeDetail)
    {
        var createdContainerTypeDetail = _context.ContainerTypeDetails.Add(new ContainerTypeDetail
        {
            contype_id = containerTypeDetail.contype_id ?? string.Empty,
            contype_type = containerTypeDetail.contype_type ?? string.Empty,
            contype_height = containerTypeDetail.contype_height,
            contype_width = containerTypeDetail.contype_width,
            contype_code = containerTypeDetail.contype_code ?? string.Empty
        });

        await _context.SaveChangesAsync();

        return Results.Created($"/ContainerTypeDetails/{createdContainerTypeDetail.Entity.Id}", createdContainerTypeDetail.Entity);
    }

    public async Task<IResult> UpdateContainerTypeDetail(int id, ContainerTypeDetailRequest containerTypeDetail)
    {
        var containerTypeDetailsToUpdate = await _context.ContainerTypeDetails.FindAsync(id);

        if (containerTypeDetailsToUpdate == null)
        {
            return Results.NotFound();
        }

        if (containerTypeDetail.contype_id != null)
        {
            containerTypeDetailsToUpdate.contype_id = containerTypeDetail.contype_id;
        }

        if (containerTypeDetail.contype_type != null)
        {
            containerTypeDetailsToUpdate.contype_type = containerTypeDetail.contype_type;
        }

        if (containerTypeDetail.contype_height != null)
        {
            containerTypeDetailsToUpdate.contype_height = containerTypeDetail.contype_height;
        }

        if (containerTypeDetail.contype_width != null)
        {
            containerTypeDetailsToUpdate.contype_width = containerTypeDetail.contype_width;
        }

        if (containerTypeDetail.contype_code != null)
        {
            containerTypeDetailsToUpdate.contype_code = containerTypeDetail.contype_code;
        }

        await _context.SaveChangesAsync();

        return Results.Ok(containerTypeDetailsToUpdate);
    }

    public async Task<IResult> DeleteContainerTypeDetail(int id)
    {
        var containerTypeDetail = await _context.ContainerTypeDetails.FindAsync(id);

        if (containerTypeDetail == null)
        {
            return Results.NotFound();
        }

        _context.ContainerTypeDetails.Remove(containerTypeDetail);

        await _context.SaveChangesAsync();

        return Results.NoContent();
    }
}
