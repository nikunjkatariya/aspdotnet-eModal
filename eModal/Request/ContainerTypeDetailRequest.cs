namespace eModal.Request
{
    public record ContainerTypeDetailRequest(
        string? contype_id,
        string? contype_type,
        int? contype_height,
        int? contype_width,
        string? contype_code
    );
}
