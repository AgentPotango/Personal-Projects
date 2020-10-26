%
% EXTRACTFEATURES( digdata )
%
% Arguments: 'digdata' is a 2-d matrix, size 16x16.
%
% Process the supplied 2d matrix to generate a lower dimensional
% feature vector, to be used in a learning algorithm.
%
% The returned vector is the sum of pixel values in each of the 16 columns.
% Alternatives might be the sum of values in the 16 rows, or combinations
% of the two, or other statistics of the pixels, like standard deviation.
%
% Note: This MUST return a 1-d array
%
%
function feature = extractmyfeatures(digdata, featureNo)

%sum the values in along matrix dimension 1 (rows)
switch featureNo
    case 1
        feature = sum(digdata,1);
    case 2
        feature = digdata(:,1:2:16);
        feature = reshape(feature,1,128);
    case 3
         feature = digdata(:,1:4:16);
         feature = reshape(feature,1,64);
    case 4
          nextValue(1) = 1;
          nextValue(2) = 1;
          i = 3;
          noOfColumns = 0;
          while noOfColumns <= 16
            nextValue(i) = nextValue(i-1) + nextValue(i-2);
            noOfColumns = nextValue(i);
            if noOfColumns <= 16
                i = i +1;
            end  
          end
          m = [nextValue(1), nextValue(2)];
          for j = 3:i-1
              m = [m,nextValue(j)];
          end
          feature = sum(digdata(:,m));
          feature = reshape(feature, 1,7);
    case 5 
          maxColValue = sum(digdata,1);
          maxValue = sum(maxColValue,2);
          topQuadrant = 0;
          leftQuadrant = 0;
          for i=1:16
              for j=1:8
                  topQuadrant = topQuadrant + digdata(j,i);
                  leftQuadrant = leftQuadrant + digdata(i,j);
              end
          end
          topPercent = topQuadrant/maxValue;
          leftPercent = leftQuadrant/maxValue;
          feature = [topPercent, leftPercent];  
     case 6
          maxColValue = sum(digdata,1);
          maxValue = sum(maxColValue,2);
          topQuadrant = 0;
          rightQuadrant = 0;
          for i=1:16
              for j=1:8
                  topQuadrant = topQuadrant + digdata(j,i);
                  rightQuadrant = rightQuadrant + digdata(i,j+8);
              end
          end
          topPercent = topQuadrant/maxValue;
          rightPercent = rightQuadrant/maxValue;
          feature = [topPercent, rightPercent];
    case 7
          feature = digdata(:,[2,3,5,7,11,13]);
          feature = reshape(feature,1,96);
    case 8
        feature = reshape(digdata,1,256);   
    case 9 
        newDigdata = digdata(:,1:2:16);
        maxColValue = sum(newDigdata,1);
        maxValue = sum(maxColValue,2);
        topQuadrant = 0;
        rightQuadrant = 0;
        for i=1:8
            for j=1:4
                topQuadrant = topQuadrant + newDigdata(j,i);
                rightQuadrant = rightQuadrant + newDigdata(i,j+4);
            end
        end
        topPercent = topQuadrant/maxValue;
        rightPercent = rightQuadrant/maxValue;
        feature = [topPercent, rightPercent];   
    otherwise
        error('please enter a feature number between 1 and 9');
end
