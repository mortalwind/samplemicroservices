namespace ContactService.Core.Abstract;

/// <summary>
/// Sayfalamalı arama isteği sonuç soyut sınıfı
/// </summary>
/// <typeparam name="TEntity">Dönen değer</typeparam>
public abstract class PagingResult<TEntity>
{
    /// <summary>
    /// Toplam kayıt sayısı
    /// </summary>
    public int TotalCount { get; set; } = 0;
    /// <summary>
    /// Dönen değerler
    /// </summary>
    public IEnumerable<TEntity> Result { get; set; }
}
