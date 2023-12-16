﻿using AutoMapper;
using Core.Abstracts;
using Core.Dtos.Requests;
using Core.Dtos.Responses;
using Core.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Core.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;
    CategoryBusinessRules _categoryBusinessRules;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }

    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        await _categoryBusinessRules.MaximumCategoryCountIsTen();

        Category category = _mapper.Map<Category>(createCategoryRequest);

        var createdCategory = await _categoryDal.AddAsync(category);

        CreatedCategoryResponse result = _mapper.Map<CreatedCategoryResponse>(createdCategory);

        return result;
    }
}