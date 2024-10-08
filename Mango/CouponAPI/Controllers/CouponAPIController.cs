﻿using CouponAPI.Data;
using CouponAPI.Models;
using CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        private ResponseDto _response;
        public CouponAPIController(AppDbContext context)
        {
            _context = context;
            _response = new ResponseDto();
        }

        [HttpGet]

        public ResponseDto Get() {

            try
            {
                IEnumerable<Coupon> objList = _context.Coupons.ToList();
                _response.Result = objList;
            }
            catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            
            }

            return _response;
        
        }

        [HttpGet]
        [Route("{id:int}")]

        public ResponseDto Get(int id)
        {

            try
            {
                Coupon obj = _context.Coupons.First(u=>u.CouponId==id);
                _response.Result =obj;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;

            }

            return _response;

        }

    }
}
