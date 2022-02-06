namespace ContactService.Core.Abstract;

/// <summary>
/// Sayfalama ile arama isteği soyut sınıfı
/// </summary>
public abstract class PagingRequest
{
    /// <summary>
    /// Sayfa indeksi
    /// </summary>
    public int PageIndex { get; set; } = 1;

    /// <summary>
    /// Sayfa başına görüntülenecek kayıt
    /// </summary>
    public int PageSize { get; set; } = 10;
}
