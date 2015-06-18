namespace USC.GISResearchLab.Geocoding.Core.Metadata.Qualities
{
    public enum GeocodeQualityType
    {
        Unmatchable,
        Unknown,
        GPS,
        BuildingFrontDoor,
        BuildingCentroid,
        ExactParcelCentroidPoint,
        ExactParcelCentroid,
        NearestParcelCentroidPoint,
        NearestParcelCentroid,
        ActualLotInterpolation,
        UniformLotInterpolation,
        AddressRangeInterpolation,
        StreetIntersection,
        StreetCentroid,
        ZCTAPlus5Centroid,
        ZCTAPlus4Centroid,
        ZCTAPlus3Centroid,
        ZCTAPlus2Centroid,
        ZCTAPlus1Centroid,
        ZCTACentroid,
        USPSZipPlus5LineCentroid,
        USPSZipPlus4LineCentroid,
        USPSZipPlus5AreaCentroid,
        USPSZipPlus4AreaCentroid,
        USPSZipPlus3AreaCentroid,
        USPSZipPlus2AreaCentroid,
        USPSZipPlus1AreaCentroid,
        USPSZipAreaCentroid,
        CityCentroid,
        ConsolidatedCityCentroid,
        CountySubdivisionCentroid,
        CountyCentroid,
        StateCentroid,
        CountryCentroid,
        DynamicFeatureCompositionCentroid,
    }

}
